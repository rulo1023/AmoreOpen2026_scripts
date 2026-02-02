#include "../lib/_constants.cs"

AssignGroups(_333mbf-r1, [AssignmentSet("everyone", true, true)], attemptNumber=1, overwrite=true)

# TODO finetunear los pesos

AssignStaff(_333mbf-r1,
            true,
            Persons(true),
            [Job("judge",
                 15, eligibility=EligibleVolunteer()),
             Job("delegate",
                 2, eligibility=IsDelegating())],
            [PersonPropertyScorer((Age() > 30), 15), PersonPropertyScorer(CompetingIn(_333bf), 20),
             PersonPropertyScorer(CompetingIn(_333), 10), PersonPropertyScorer((WcaId() == "2022MENE02"), 1000)],
            overwrite=true)


CreateCompetitionGroupsAssignments([2015SANC18,2019CALO01,2017NICO01],
                                   "3x3x3 Multi-Blind Scrambling",
                                   2026-02-21T15:20,
                                   2026-02-21T15:50,
                                   true)


AssignGroups(_444bf-r1, [AssignmentSet("everyone", true, true)], overwrite=true)
AssignGroups(_555bf-r1, [AssignmentSet("everyone", true, true)], overwrite=true)

AssignStaff(_444bf-r1,
            true,
            Persons(true),
            [Job("judge",
                 15, eligibility=EligibleVolunteer()),
             Job("delegate",
                 2, eligibility=IsDelegating())],
            [PersonPropertyScorer((Age() > 30), 15), PersonPropertyScorer(CompetingIn(_333bf), 20),
             PersonPropertyScorer(CompetingIn(_333), 10), PersonPropertyScorer((WcaId() == "2022MENE02"), 1000)],
            overwrite=true)