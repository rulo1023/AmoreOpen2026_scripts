#include "_constants.cs"
#include "_assignment_sets.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"


# Args:
# 1: Round
# 2: Number of top people
# 3: Assign Delegates
Define("AssignGroupsStages",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets({1, Round}, {2, Number}), [], [StationAssignmentRule(true, "ascending", PsychSheetPosition(EventForRound({1, Round})))],overwrite=true))

Define("AssignGroups2x2x3x3",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets2x2x3x3({1, Round}, {2, Number}), [], [StationAssignmentRule(true, "ascending", RoundPosition(PreviousRound({1, Round})))],overwrite=true))


# Args:
# 1: Round
# 2: Date of the round
# 3: Number of judges
# 4: Number of runners
# 5: Number of scramblers
# 6: Number of delegates
Define("AssignStaffStages",
       AssignStaff({1, Round},
                   true,
                   Persons(true),
                   [Judges({3, Number}),
                    Runners({4, Number}),
                    Scramblers({5, Number}, EventForRound({1, Round})),
                    Delegates({6, Number})],
                   VolunteerScorers(EventForRound({1, Round}), {2, Date}),
                   unavailable=Unavailable(Arg<Person>()),
                   overwrite=true))


# Args:
# 1: Round
Define("TopCompetitorsPerRound", (Length(Filter(Groups({1, Round}), (Stage() == RED))) * 4))