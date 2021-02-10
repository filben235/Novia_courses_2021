#if !defined EXITREASONS_H
#define EXITREASONS_H

// Here we name them, tell that they exist somewher so the compiler knows to bind them later

// reason : 0 means 'ok', + numbers would mean with varning and - numbers would mean errors. 
extern const int InputFailExitReason;
extern const int ErrorInRangeExitReason;
extern const int NormalExitReason;
extern const int SomeVarningExitReason;

// Global variable. Normally we avoid them if possible.
// Need pointer or ref to fix, so we fix it when we know how.
extern int g_ExitReason;


#endif
