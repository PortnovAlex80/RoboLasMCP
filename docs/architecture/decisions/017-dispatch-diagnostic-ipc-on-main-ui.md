# 017. Dispatch diagnostic IPC model access on the main UI thread

- **Status:** Accepted for diagnostic builds; live host behavior still requires acceptance
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

ADR 016 serializes the 15 normal commands, but diagnostic IPC bypassed that
dispatcher. `GetAlignmentInfo`, project exploration and alignment activation
accessed Topomatic models directly on a Remoting thread. `GetContextSnapshot`
and drawing commands used `CadView.Invoke` only after reading
`ApplicationHost.ActiveDocument` from that thread through
`IpcTestServer.CadView`. The diagnostic client expects synchronous string or
dictionary responses, and the refactoring plan requires diagnostic integration
testing to remain available. Rail 16 exposes `IApplicationHost.MainForm` as
`IMainForm : ISynchronizeInvoke` with `IsHandleCreated` and `Invoke(Delegate)`.

## Decision drivers and options

Scores are 1–5, higher is better. Correct SDK threading, regression risk and
preserving diagnostic test functions carry the most weight.

| Driver | Weight | A: MainForm dispatch | B: CadView dispatch | C: disable model IPC |
|---|---:|---:|---:|---:|
| SDK model access on UI | 5 | 4 | 3 | 4 |
| Regression risk | 5 | 4 | 3 | 1 |
| Diagnostic capability | 4 | 5 | 4 | 1 |
| Testability | 3 | 4 | 3 | 4 |
| Implementation cost | 2 | 3 | 3 | 5 |
| Reversibility | 2 | 4 | 4 | 5 |
| **Weighted total** | | **86** | **69** | **61** |

A adds a synchronous `DiagnosticUiDispatcher`: it acquires the same
nonblocking operation lease as normal commands, checks that the main form has
a handle, invokes the model operation on its UI thread, and returns a stable
busy or unavailable result before work starts. The existing public IPC
signatures remain; their former bodies become private UI methods. The body
resolves the active document/model at execution time and returns only a
string or dictionary. No Topomatic model object crosses back to Remoting.

B uses `CadView.Invoke` as the outer dispatch. It matches two existing
methods, but `IpcTestServer.CadView` currently obtains `ActiveDocument` before
dispatch and some project-model queries do not require an active CAD view.
It would need an additional UI bootstrap path. C retains signatures while
returning disabled errors; it avoids questionable SDK access but removes most
diagnostic integration commands required by the plan and test client.

## Pre-mortem and Red Team

Assume A failed in a live diagnostic session:

1. `MainForm.Invoke` is queued while the form closes. The dispatcher checks
   the handle and maps a pre-callback disposal/invalid-handle error to
   `ui_unavailable`; it releases the lease in `using`. A host close race still
   needs testing.
2. The CAD view belongs to a different UI thread. The Red Team identified a
   possible deadlock from nested `CadView.Invoke` inside `MainForm.Invoke`.
   Each view-based UI body now checks `cv.InvokeRequired` before its nested
   call and returns `view_thread_mismatch` or an explicit error without
   changing CAD.
3. The active document changes while a request waits for UI dispatch.
   The request resolves the active document inside the UI body. Draw methods
   recheck that the captured view is still active immediately before adding
   an entity; section generation already checks this before `Clear/Add`.
4. An IPC method acquires the lease and fails before or during dispatch.
   The .NET 3.5 fixture covers busy, uncreated/disposed form, callback failure
   propagation, including callback `ObjectDisposedException`, and later lease
   acquisition. It cannot verify Topomatic's
   message pump or native commands.

The independent Red Team's strongest objection was the possible nested
cross-thread `Invoke` deadlock; the view-thread check is the mitigation. It
also pointed out that a gate is not a CAD transaction and cannot prevent
Topomatic or another plugin from changing the document. The decision does
not claim otherwise.

## Decision and consequences

Choose A. Keep all current public IPC methods for client compatibility.
Only `Ping` and the local numerical `RunAllTests` bypass UI dispatch. The
normal build still excludes all diagnostic IPC sources; the package verifier
uses an exact three-file diagnostic allowlist. A copied Rail 16 diagnostic
Release build and the production dispatcher fixture compile successfully.

The remaining host gate must exercise IPC during a long command, modal
progress, document close/switch, and alignment activation. The copied SDK
confirms API shape but cannot prove UI scheduling or project identity in a
live Topomatic session. `GenerateSections` still uses `Clear/Add`, so it must
only be exercised on a disposable project; this change does not make that
CAD edit undoable.

## Decision Journal

**Ex-ante expectation:** no model-facing diagnostic IPC body starts while a
normal plugin command holds the lease, and all such bodies execute in the
main form's UI callback or return a busy/unavailable status.

**Check trigger:** first isolated diagnostic GUI run and any new public method
on `LasTerrainTestService` that reads or changes SDK model state.

**What would change this decision:** a host project whose active `CadView`
consistently belongs to a different thread, a deadlock in `MainForm.Invoke`
during modal Topomatic operations, or a closing-window callback that runs
after an unavailable result.
