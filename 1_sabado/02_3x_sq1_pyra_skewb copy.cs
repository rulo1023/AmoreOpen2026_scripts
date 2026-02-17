#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"
#include "../lib/_unavailabilities.cs"



Map([_pyram-r2, _skewb-r2, _sq1-r2],
    AssignGroups(Arg<Round>(), EveryoneSet(), [], 
                        [StationAssignmentRule(true, "ascending", 
                        RoundPosition(PreviousRound({1, Round})))], overwrite=true))
                       

AssignStaffStages(_pyram-r2, 2025-12-07, 14, 3, 3, 1)
AssignStaffStages(_skewb-r2, 2025-12-07, 14, 3, 3, 1)
AssignStaffStages(_sq1-r2, 2025-12-07, 14, 3, 3, 1)


AssignGroupsStages2x2x3x3(_333-r2, 12)

AssignStaffStages(_333-r2, 2025-12-07, 18, 3, 3, 1)