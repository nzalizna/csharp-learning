NULL w SQL i C# — ściągawka

══════════════════════════════
OPERATORY: SQL → C#
══════════════════════════════
AND  →  &&
OR   →  ||
NOT  →  !
=    →  ==
<>   →  !=
IS NULL      →  == null
IS NOT NULL  →  != null

══════════════════════════════
NULL w SQL = "nie wiem / не знаю"
══════════════════════════════
Dwie zasady do zapamiętania:
  FALSE AND cokolwiek = FALSE
  TRUE  OR  cokolwiek = TRUE
  Wszystko inne z NULL = NULL

Przykłady:
  NULL AND NULL  =  NULL
  TRUE AND NULL  =  NULL
  FALSE AND NULL =  FALSE  ✓

  NULL OR NULL   =  NULL
  TRUE OR NULL   =  TRUE   ✓
  FALSE OR NULL  =  NULL

  NULL = NULL    =  NULL   ✗ nigdy tak!
  NULL IS NULL   =  TRUE   ✓ zawsze tak!

══════════════════════════════
NULL w C# vs SQL
══════════════════════════════
SQL: NULL = nieznana wartość
C#:  NULL = brak wartości

int, double, bool → NIE mogą być NULL
string            → MOŻE być NULL