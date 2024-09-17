# TPM Fingerprint Utility

This utility shows the globally unique TPM fingerprint of the current device.

Extracting the id requires administrative permissions.
The applications will automatically ask for this if necessary upon launch.

## Command Line Usage

Prints the hex encoded id if run without arguments.

- `/V`: Show additional properties
- `/B64`: Print id as base64 encoded instead of hex encoded
- `/?`: Show help

If the fingerptint cannot be obtained, a nonzero exit code is returned.
Use the help for more details on exit codes.

## UI Usage

Simply double click the executable. It immediately shows the id.
