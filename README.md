# 🛡️ BattleArena

**BattleArena** este o aplicație de consolă în .NET care simulează lupte între soldați de diferite tipuri. Proiectul folosește concepte OOP și două Design Patterns populare pentru a oferi o structură extensibilă și clară.

---

## 📁 Structura proiectului

- `Program.cs` – Punctul de intrare al aplicației.
- `ISoldier.cs` – Interfața de bază pentru soldați.
- `Archer.cs`, `Healer.cs`,`Warrior.cs` – Tipuri specifice de soldați.
- `BattleArenaManager.cs` – Se ocupă de logica luptei.
- `IAttackStrategy.cs`, `NormalAttack.cs`, `HeavyAttack.cs`, `ArrowAttack.cs`, `PoisonAttack.cs` – Strategie de atac (Strategy Pattern).
- `SoldierFactory.cs` – Creează soldați pe baza unui tip (Factory Pattern).

---

## 💡 Design Patterns utilizate

### 1. Strategy Pattern

🔹 **Scop:** Permite schimbarea comportamentului de atac în mod flexibil, fără a modifica clasele soldaților.

🔹 **Cum funcționează:**
- Se definește o interfață `IAttackStrategy`.
- Strategii precum `NormalAttack` și `HeavyAttack` o implementează.
- Fiecare soldat primește o strategie de atac prin constructor.

🔹 **Exemplu de cod:**
```csharp
public interface IAttackStrategy {
    void Attack(Soldier attacker, Soldier target);
}

public class MeleeAttackStrategy : IAttackStrategy {
    public void Attack(Soldier attacker, Soldier target) {
        target.Health -= 10;
    }
}
```

### 2. Factory Pattern

🔹 **Scop:** Separă logica de creare a soldaților într-o clasă dedicată, făcând codul mai organizat și ușor de extins.

🔹 **Cum funcționează:**
- `SoldierFactory` este o clasă statică cu o metodă `Create` care returnează instanțe de soldați în funcție de tip.
- Tipuri de soldați precum `Archer`, `Healer` și `Warrior`.
- Ușor de adăugat noi tipuri de soldați fără a modifica codul existent.

🔹 **Exemplu de cod:**
```csharp
 public static class SoldierFactory
 {
     public static ISoldier CreateSoldier(string type, string name)
     {
         return type.ToLower() switch
         {
             "warrior" => new Warrior(name),
             "archer" => new Archer(name),  
             "healer" => new Healer(name),
             _ => throw new ArgumentException($"Unknown soldier type: {type}")
         };
     }
 }
```
