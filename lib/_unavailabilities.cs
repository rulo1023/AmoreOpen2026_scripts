# Args:
# 1: Person
Define("Unavailable",
            Switch({1, Person},
               [
                Tuple(2015SANC18, [UnavailableBetween(2026-02-21T15:20, 2026-02-21T15:50)]),   # josete
                Tuple(2019CALO01, [UnavailableBetween(2026-02-21T15:20, 2026-02-21T15:50)]),   # peio
                Tuple(2017NICO01, [UnavailableBetween(2026-02-21T15:20, 2026-02-21T15:50)]),   # nico
                Tuple(2022MART26, [UnavailableBetween(2026-02-21T00:00, 2026-02-21T12:00)]),   # astrid
                Tuple(2018NAYL01, [UnavailableBetween(2026-02-21T00:00, 2026-02-21T12:00)]),   # gladys
                Tuple(2025MATA02, [UnavailableBetween(2026-02-21T00:00, 2026-02-21T15:00)]),   # martin garcía
                Tuple(2023LOIS01, [UnavailableBetween(2026-02-21T15:00, 2026-02-21T23:00)]),   # oscar 
                Tuple(2023GERV01, [UnavailableBetween(2026-02-21T00:00, 2026-02-21T23:00)]),   # carlota
                Tuple(2023LOIS02, [UnavailableBetween(2026-02-21T00:00, 2026-02-21T23:00)])    # roberto
               ],
               defaultValue=[])
        )
       
