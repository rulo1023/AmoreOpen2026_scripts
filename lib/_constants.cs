# Volunteer teams and tasks
#define TEAM "team"
#define DATAENTRY "staff-dataentry"
#define ORGANIZER "organizer"
#define DELEGATE "delegate"
#define CORE_VOLUNTEER "core-volunteer"
#define AES_TEAM "aes"
#define DATA_TEAM "data"
#define AUX_TEAM "aux"
#define NO_TASKS "no-tasks"
#define AUX_TASKS "aux-tasks"
#define STAFF_AUXILIAR "staff-sala-aux"
#define 333mbf_JUDGE "333mbf-judge"
#define 333mbf_DELEGATE "333mbf-delegate"
#define 444bf_JUDGE "444bf-judge"
#define 444bf_SCRAMBLER "444bf-scrambler"
#define 444bf_DELEGATE "444bf-delegate"
#define 555bf_JUDGE "555bf-judge"
#define 555bf_SCRAMBLER "555bf-scrambler"
#define 555bf_DELEGATE "555bf-delegate"

# Rooms
#define FRONTON "Frontón"
#define RED "Rojo"
#define GREEN "Verde"
#define AUX "Sala Blind"
#define TEST1 "Tests1"
#define TEST2 "Tests2"

# aqui he borrado cosas, revisar
Define("AllStages", [RED, GREEN])
Define("TestStages", [TEST1, TEST2])

Define("EligibleVolunteer",
       And(Registered(),
           Not(HasRole(ORGANIZER)),
           Not(HasRole(DELEGATE)),
           Not(IsNull(WcaId()))))

Define("IsDelegating", And(HasRole(DELEGATE),
                           Not(HasRole(ORGANIZER))
                           ))