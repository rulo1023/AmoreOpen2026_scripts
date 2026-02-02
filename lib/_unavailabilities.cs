# Args:
# 1: Person
Define("Unavailable",
        If(In(WcaId({1, Person}), ["2015SANC18","2019CALO01","2017NICO01"]),
           [UnavailableBetween(2026-02-21T15:20, 2026-02-21T15:50)], [])
       )
