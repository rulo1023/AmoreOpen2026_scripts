#include "_constants.cs"
#include "_eligible_scramblers.cs"

Define("ScrambleSpeedWeight",
       [Tuple(_333, 2),
        Tuple(_222, 2),
        Tuple(_444, 4),
        Tuple(_sq1, 5),
        Tuple(_pyram, 2),
        Tuple(_skewb, 2),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1)])


Define("StandardJobNames", ["judge", "scrambler", "runner"])

# Args:
# 1: Event
# 2: Date
Define("VolunteerScorers", 
        [JobCountScorer(-10),
        PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
        PriorAssignmentScorer(-2, 0, 2026-02-20T00:00),

        SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
        ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),

        ConsecutiveJobScorer(30, -5, 0, jobs=["scrambler"]),

        SameJobScorer(0, -100, 10, jobs=["delegate"]),
        ConsecutiveJobScorer(-500, 0, 0, jobs=["delegate"]),

        FollowingGroupScorer(-50, maxMinutes=10),

        PersonPropertyScorer((CompetingIn(Event()) && Not(HasRole(DELEGATE))), 50),

        ConditionalScorer(CanScramble({1, Event}),
                          true,
                          In<String>(["judge", "runner"]),
                          true,
                          -50)])



