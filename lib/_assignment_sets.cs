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

Define("TopCompetitorsSet2x2x3x3",
       AssignmentSet("top3",
                     (RoundPosition(PreviousRound({1, Round})) <= {2, Number}),
                     ((Stage() == "Rojo") && (GroupNumber() == Length(Groups(Round())))),
                     true))

Define("OrganizersSet",
       AssignmentSet("organizers",
                     HasRole(ORGANIZER),
                     (Stage() == RED)))

Define("DelegatesSet",
       AssignmentSet("delegates",
                     IsDelegating(),
                     (Stage() == RED)))

Define("GroupsForMulti",
       [Tuple(_333, [1])])

Define("MultiSet",
       AssignmentSet("multi",
                     In(2026-02-21T15:55, Map(AssignedGroups(), StartTime())),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsForMulti()))))

Define("GroupsFor444bf",
       [Tuple(_444, [1]),
        Tuple(_222, [3,4])])

Define("fourbfSet",
       AssignmentSet("444bf",
                     In(2026-02-21T10:30, Map(AssignedGroups(), StartTime())),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsFor444bf()))))

# Args:
# 1: Include Delegates
Define("EveryoneSet", AssignmentSet("everyone", true, true))

# Args:
# 1: Round
# 2: Number of top people

Define("NormalRoundAssignmentSets",
       Concat(If(In({1, Round}, [_222-r1, _444-r1]),
                 [fourbfSet()],
                 []),
              If(In({1, Round},  [_333-r1]),
                 [MultiSet()],
                 []),
              [TopCompetitorsSet({1, Round}, {2, Number}),
              OrganizersSet(),
              DelegatesSet(),
              EveryoneSet()]))

# Args:
# 1: Round
# 2: Number of top people

Define("NormalRoundAssignmentSets2x2x3x3",
       [TopCompetitorsSet2x2x3x3({1, Round}, {2, Number}),
       OrganizersSet(),
       DelegatesSet(),
       EveryoneSet()])


