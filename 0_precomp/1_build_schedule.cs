#include "../lib/_constants.cs"


CreateRoom(FRONTON, "#304a96")
CreateRoom(RED, "#ff0000")
CreateRoom(GREEN, "#60c828")
CreateRoom(AUX, "#fc00df")

# Aux
CreateGroups(_444bf-r1, 1, AUX, 2026-02-21T10:30, 2026-02-21T12:00, useStageName=false)
CreateGroups(_555bf-r1, 1, AUX, 2026-02-21T10:30, 2026-02-21T12:00, useStageName=false)
CreateGroups(_333mbf-r1-a1, 1, AUX, 2026-02-21T15:55, 2026-02-21T17:10, useStageName=false)
CreateMiscActivity("Multi Blind cube submission", "other-multi", AUX, 2026-02-21T15:00, 2026-02-21T15:20)

# Main rooms - Sat morning
Map(AllStages(), CreateGroups(_444-r1, 4, 2026-02-21T10:00, 2026-02-21T11:30))
Map(AllStages(), CreateGroups(_222-r1, 4, 2026-02-21T11:30, 2026-02-21T12:50))
Map(AllStages(), CreateGroups(_333oh-r1, 3, 2026-02-21T12:50, 2026-02-21T14:00))

# Main rooms - Sat afternoon
Map(AllStages(), CreateGroups(_333-r1, 4, 2026-02-21T15:20, 2026-02-21T17:10))
Map(AllStages(), CreateGroups(_sq1-r1, 2, 2026-02-21T17:10, 2026-02-21T17:50))
Map(AllStages(), CreateGroups(_333bf-r1, 2, 2026-02-21T17:50, 2026-02-21T18:30))
Map(AllStages(), CreateGroups(_pyram-r1, 4, 2026-02-21T18:30, 2026-02-21T19:40))
Map(AllStages(), CreateGroups(_skewb-r1, 3, 2026-02-21T19:40, 2026-02-21T20:35))

# Main rooms - Sun morning
Map(AllStages(), CreateGroups(_333-r2, 3, 2026-02-22T10:00, 2026-02-22T11:10))
CreateGroups(_skewb-r2, 1, RED, 2026-02-22T11:10, 2026-02-22T11:30)
CreateGroups(_pyram-r2, 1, RED, 2026-02-22T11:30, 2026-02-22T11:50)
CreateGroups(_sq1-r2, 1, RED, 2026-02-22T11:50, 2026-02-22T12:10)
Map(AllStages(), CreateGroups(_333-r3, 1, 2026-02-22T12:10, 2026-02-22T12:30))
CreateGroups(_333oh-r2, 1, RED, 2026-02-22T12:30, 2026-02-22T12:50)
Map(AllStages(), CreateGroups(_222-r2, 2, 2026-02-22T12:50, 2026-02-22T13:30))
CreateGroups(_444-r2, 1, RED, 2026-02-22T13:30, 2026-02-22T13:55)

# Finales Tarde
CreateGroups(_222-r3, 1, RED, 2026-02-22T15:10, 2026-02-22T15:30)
CreateGroups(_333bf-r2, 1, RED, 2026-02-22T15:30, 2026-02-22T16:00)
CreateGroups(_333-r4, 1, RED, 2026-02-22T16:00, 2026-02-22T17:30)

# Extra Frontón
CreateMiscActivity("Check-in", "other-checkin", FRONTON, 2026-02-21T09:30, 2026-02-21T14:00)
CreateMiscActivity("Check-in", "other-checkin", FRONTON, 2026-02-21T15:00, 2026-02-21T19:40)
CreateMiscActivity("On-site registration", "other-checkin", FRONTON, 2026-02-21T09:30, 2026-02-21T10:00)
CreateMiscActivity("Apertura de puertas", "other-checkin", FRONTON, 2026-02-22T09:45, 2026-02-22T10:00)

CreateMiscActivity("Tutorial for new competitors", "other-tutorial", FRONTON, 2026-02-21T09:45, 2026-02-21T10:00)
CreateMiscActivity("Tutorial for new competitors", "other-tutorial", FRONTON, 2026-02-21T15:00, 2026-02-21T15:20)

CreateMiscActivity("Lunch", "other-lunch", FRONTON, 2026-02-21T14:00, 2026-02-21T15:00)
CreateMiscActivity("Lunch", "other-lunch", FRONTON, 2026-02-22T13:55, 2026-02-22T15:10)

CreateMiscActivity("Awards", "other-awards", FRONTON, 2026-02-22T17:30, 2026-02-22T18:15)