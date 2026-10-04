# 016. Serialize production plugin commands

- **Status:** Accepted for the production command dispatcher; diagnostic IPC remains a separate gate
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

All 15 registered production commands enter through `Module` and
`SectionCommandRunner`, which previously ran a resolved use case without a
concurrency check. The commands share `WaitProgress`, SDK LiDAR buffers and,
until polygon v2 is wired, static polygon collections. The Rail 16 SDK does
not declare thread safety for these borrowed model resources. The refactoring
plan section 4.6 asks for a restriction on simultaneous mutating plugin
commands while these resources remain shared. A document-specific key is not
available at dispatch: only `CadView` is supplied, and one project can have
multiple views.

The copied SDK's decompiled `WaitProgress.BeginProgress` starts a
`BackgroundWorker`, shows a modal progress form while it is busy, and closes
that form from the worker-completion handler. Thus its normal path returns
after the callback. A forced external close of the form was not tested in the
host and is not a basis for claiming arbitrary worker lifetime safety.

## Decision drivers and options

Scores are 1–5, higher is better. Weights reflect the plan's priority of
correctness without regression and the current lack of live host acceptance.

| Driver | Weight | A: global runner guard | B: runner and IPC guard now | C: per-project/resource guard |
|---|---:|---:|---:|---:|
| Correctness for production commands | 5 | 4 | 4 | 2 |
| Regression risk | 5 | 5 | 3 | 2 |
| Entry-point coverage | 4 | 3 | 5 | 3 |
| Testability | 3 | 5 | 3 | 2 |
| Implementation cost | 2 | 5 | 2 | 1 |
| Reversibility | 2 | 5 | 3 | 2 |
| **Weighted total** | | **92** | **74** | **44** |

A acquires one nonblocking, process-local lease before resolving a command
and releases it in `finally` through `using`. A busy entry returns immediately
and writes a trace instead of opening a second modal dialog. This covers
dialogs, progress, interactive drawing, calculation and application for the
ordinary command route. It is coarse: settings and read-only commands also
wait until the active command ends by being rejected and retried manually.

B shares the same lease with all model-facing diagnostic IPC calls. It covers
more entry points, but several existing IPC methods access or mutate the SDK
from a Remoting thread. A gate would not fix that host-thread violation. Those
methods need a separate UI-thread migration or restriction, with disposable
host verification. B is the intended follow-up, not a claim of current
diagnostic safety.

C acquires project/resource leases after resolving model identity. It could
allow independent projects to run concurrently, but `WaitProgress` and v1
polygon stores remain process-global. Project URI is not verified across
Save As and reopen. Extra lock ordering and SDK lifetime assumptions would
make a false safety claim likely.

## Pre-mortem and Red Team

Assume A failed after six months:

1. A progress form closes before its worker; the runner releases the lease
   while borrowed arrays are still used. The copied SDK shows the normal
   modal/completion path, but a forced-close host probe remains required.
2. An IPC test mutates CAD while a production command runs. The diagnostic
   service bypasses the runner; do not claim diagnostic serialization. Migrate
   model-facing IPC methods to the CAD UI thread and the shared lease before
   enabling concurrent diagnostic tests.
3. A nested command waits on a lock in the UI message loop. The chosen lease
   rejects immediately through `Interlocked.CompareExchange`; it never waits
   and has no same-thread recursion exception.
4. Duplicate lease disposal releases another operation. `Dispose` uses an
   idempotent exchange, covered by an actual-runner fixture.

The independent Red Team emphasized the off-UI-thread IPC methods and warned
that a gate cannot protect against Topomatic or other plugins changing a
document. It also advised against a modal busy warning during `WaitProgress`.
The decision incorporates those limits: this change covers production command
entry only, uses a nonmodal trace on rejection, and does not replace target
revalidation before CAD application.

## Decision and consequences

Choose A as the current step. `PluginOperationGate` owns a single process-local
lease; `SectionCommandRunner` acquires it before the use case and releases it
on success, cancellation, exception or unknown command. The .NET 3.5 fixture
compiles the actual runner and gate and checks competing threads, nested
calls, exception recovery and duplicate disposal.

This prevents two normal LAS_TERRAIN commands from overlapping. It does not
establish SDK thread safety, protect another plugin's changes, serialize
diagnostic IPC, or verify all Topomatic progress-window exit paths. Those
remain separate requirements before full refactoring acceptance.

## Decision Journal

**Ex-ante expectation:** simultaneous production command attempts never run
their use cases together; cancellation and exceptions allow a later command.

**Check trigger:** first isolated GUI test with a long progress command and a
second command attempt, plus any change to `WaitProgress` usage or diagnostic
IPC dispatch.

**What would change this decision:** a host case where `Run` returns while
its worker remains active, or verified resource isolation allowing two
independent project commands to run safely.
