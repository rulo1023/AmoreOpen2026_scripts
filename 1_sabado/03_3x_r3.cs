#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"
#include "../lib/_unavailabilities.cs"

Map([_333-r3],
    AssignGroups(Arg<Round>(), EveryoneSet(), [], 
                        [StationAssignmentRule(true, "ascending", 
                        RoundPosition(PreviousRound({1, Round})))], overwrite=true))
                       
AssignStaffStages(_333-r3, 2025-12-07, 18, 3, 3, 1)
