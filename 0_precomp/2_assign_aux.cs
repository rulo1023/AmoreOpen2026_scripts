#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

# 1. Grupos (igual que antes)
AssignGroups(_444bf-r1, [AssignmentSet("everyone", true, true)])
AssignGroups(_555bf-r1, [AssignmentSet("everyone", true, true)])
AssignGroups(_333mbf-r1, [AssignmentSet("everyone", true, true)])

# 2. Asignación automática usando la lista centralizada
AssignStaff(_444bf-r1, 
            true, 
            Persons(In(WcaId(), EquipoAuxiliarIDs())),
            [
                Job("judge", 10),
                Job("scrambler", 2),
                Job("delegate", 1)
            ],
            [])

AssignStaff(_333mbf-r1, 
            true, 
            Persons(In(WcaId(), EquipoAuxiliarIDs())), 
            [
                Job("judge", 10),
                Job("delegate", 1)
            ],
            [])