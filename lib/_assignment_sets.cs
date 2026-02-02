#include "_constants.cs"

# Args:
# 1: Round
# 2: Number of top people
# el true ultimo es la ESTRELLITA

Define("TopCompetitorsSet",
       AssignmentSet("top",
                     (PsychSheetPosition(EventForRound({1, Round})) <= {2, Number}),
                     (Stage() == RED),
                     true))


Define("OrganizersSet",
       AssignmentSet("organizers",
                     HasRole(ORGANIZER),
                     (Stage() == RED)))

Define("DelegatesSet",
       AssignmentSet("delegates",
                     IsDelegating(),
                     (Stage() == RED)))

Define("MultiSet",
       AssignmentSet("multi",
                     CompetingIn(_333mbf),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsForMulti()))))


Define("444bfSet",
       AssignmentSet("444set",
                     CompetingIn(_444bf),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsForMulti()))))

# Args:
# 1: Include Delegates
Define("EveryoneSet", AssignmentSet("everyone", true, true))

# Args:
# 1: Round
# 2: Number of top people
# 3: Include Delegates
Define("NormalRoundAssignmentSets",
       [TopCompetitorsSet({1, Round}, {2, Number}),
       OrganizersSet(),
       DelegatesSet(),
       EveryoneSet()])