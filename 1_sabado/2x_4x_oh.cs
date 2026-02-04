#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"
#include "../lib/_unavailabilities.cs"

AssignGroupsStages2x2x3x3(_222-r2, 12)

Map([_444-r2, _333oh-r2],
    AssignGroups(Arg<Round>(), EveryoneSet(), [], 
                        [StationAssignmentRule(true, "ascending", 
                        RoundPosition(PreviousRound({1, Round})))], overwrite=true))
                       

AssignStaffStages(_444-r2, 2025-12-07, 14, 3, 3, 1)
AssignStaffStages(_222-r2, 2025-12-07, 18, 3, 3, 1)
