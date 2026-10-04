# Portable polygon files

Status: implemented on master, 2026-10-01.

The user explicitly replaced the pre/post Save As ticket workflow with saving
polygon files wherever they choose and loading them into any current project.
Cynefin: Clear. The requested workflow and file naming determine the choice;
no option-generation loop is needed.

Save exports one self-contained JSON per polygon, named
`Project.план.полигон.001.json` or `Project.поперечник.полигон.001.json`.
The user selects a destination folder and confirms replacement of matching
files. Files have a portable format identifier, coordinate convention,
vertices, date and CRS station/thickness metadata, without a project owner ID.
The version field describes this file contract and is not a migration path.

Load validates all selected files before one repository commit and appends
them to the captured current project. Plan coordinates are unchanged and the
user confirms the coordinate-system requirement. CRS contours are explicitly
rebound to the current section ID/station after confirmation. Current host
ownership and repository revisions are rechecked before publication.

Pre-mortem: wrong CRS section, changed project during dialogs, corrupt member
of a multi-file selection, overwriting exports, partial export after disk
failure. Mitigations: explicit section confirmation, pinned owner/revision,
validate-before-commit, overwrite confirmation, individually atomic file
replacement and a count of completed exports in the failure message.

The Save As commands, ticket serialization, transfer APIs and dedicated tests
are removed. Existing internal project polygon storage is retained. Source
JSON files remain independent of loaded project polygons.

Validation: production save/load commands compiled with fault-injecting host
stubs; cross-project append, current-section rebinding, invalid-file rejection,
cancel, owner changes and overwrite refusal. Release DLL and TPM verifier.
