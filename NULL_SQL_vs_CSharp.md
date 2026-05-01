NULL w SQL i C# — ściągawka

══════════════════════════════
OPERATORY: SQL → C#
══════════════════════════════
AND  →  &&   (обидва мають бути TRUE)
OR   →  ||   (хоча б одне має бути TRUE)
NOT  →  !    (перевертає значення)
=    →  ==
<>   →  !=
IS NULL      →  == null
IS NOT NULL  →  != null

══════════════════════════════
NULL w SQL = "nie wiem / не знаю"
══════════════════════════════
Уяви що 2 людини відповідають чи підуть на вечірку.
NULL = "не знаю"

AND — обидва мають погодитись:
  Маша НІ,  Петро не знає → НІ  (Маша вже відмовила)
  Маша ТАК, Петро не знає → не знаємо
  → FALSE AND NULL = FALSE
  → TRUE  AND NULL = NULL

OR — достатньо одного:
  Маша ТАК, Петро не знає → ТАК  (Маша вже погодилась)
  Маша НІ,  Петро не знає → не знаємо
  → TRUE  OR NULL = TRUE
  → FALSE OR NULL = NULL

NOT — перевертає:
  NOT TRUE  = FALSE
  NOT FALSE = TRUE
  NOT NULL  = NULL  (не знаємо що перевернути)

══════════════════════════════
Дві головні правила:
  FALSE AND що завгодно = FALSE
  TRUE  OR  що завгодно = TRUE
  Все інше з NULL = NULL
══════════════════════════════

Повна таблиця:
  NULL AND NULL  =  NULL
  TRUE AND NULL  =  NULL
  FALSE AND NULL =  FALSE  ✓

  NULL OR NULL   =  NULL
  TRUE OR NULL   =  TRUE   ✓
  FALSE OR NULL  =  NULL

  NULL = NULL    =  NULL   ✗ ніколи так!
  NULL IS NULL   =  TRUE   ✓ завжди так!

══════════════════════════════
NULL w C# vs SQL
══════════════════════════════
SQL: NULL = невідоме значення
C#:  NULL = відсутність значення

int, double, bool → НЕ можуть бути NULL
string            → МОЖЕ бути NULL