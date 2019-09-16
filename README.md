# Code Kata - Test-Driven Development - Encounter Builder

----

## TDD - 2 Laws

1. Write only enough of a test that it fails.
2. Write only enough production code to make the test pass.

----

## Exercise Requirements

Using these two laws, create an `EncounterBuilder` class that satisfies the following requirements:

Given a Party and a Bestiary:
- Throw an Exception if the Party has no characters
- Throw an Exception if the Bestiary has no creatures
- Return an EnemyEncounter object with enough enemies such that their total levels matches the Party's total levels
- Always return at least one enemy
- Never create an encounter with more than 30 enemies in an encounter
- If it is not possible exactly match the Party's total level, the Encounter Level should be slightly higher than the Party's total level

**Time Alloted:** Spend no more than 30 minutes on this exercise.

----
