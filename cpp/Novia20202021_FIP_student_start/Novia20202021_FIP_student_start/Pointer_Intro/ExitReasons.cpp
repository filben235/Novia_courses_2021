#include "ExitReaons.h"

// Here we declare and define, they will only exist in this obj-file

// reason : 0 means 'ok', + numbers would mean with varning and - numbers would mean errors. 
// Severity with rising value.
// Later on *exchange this with enums*.
const int InputFailExitReason = -2;
const int ErrorInRangeExitReason = -1;
const int NormalExitReason = 0;
const int SomeVarningExitReason = 1;

// Global variable. Normally we avoid them if possible.
// Need pointer or ref to fix, so we fix it when we know how.
int g_ExitReason = 0;
