# Počítačová hra Tetris

Ročníková práce z předmětu Informační technologie na SPŠ Třebíč[cite: 3].

* **Platforma:** C#, .NET Framework 4.8 (Windows Forms)

---

## O projektu

Cílem práce je návrh a realizace klasické počítačové hry Tetris v prostředí Microsoft Visual Studio. Hra klade důraz na čistou objektovou architekturu, oddělení herní logiky od zobrazení, plynulé ovládání a trvalé ukládání žebříčku nejlepších hráčů do souboru.

---

## Architektura a herní logika 

Herní logika je soustředěna ve složce `Jadro/` a funguje nezávisle na grafickém rozhraní.

### Klíčové třídy
* **`Pozice`**: Třída reprezentující souřadnice buňky (index řádku `Radek` a sloupce `Sloupec`) na herní desce.
* **`GameBoard`**:
  * Spravuje vnitřní mřížku o standardních rozměrech 20 řádků × 10 sloupců (`int[20, 10]`).
  * Hodnota `0` značí prázdné pole, čísla `1` až `7` značí uložený blok daného typu.
  * Zajišťuje kontrolu hranic desky (`IsInside`), detekci kolizí s již existujícími bloky (`Fits`), ukotvení dílku po dopadu (`PolozBlok`) a mazání zaplněných řádků s posunem shora dolů (`VymazatRadky`).
* **`Tetromino`**:
  * Abstraktní základ pro všech 7 standardních dílků (I, J, L, O, S, T, Z).
  * Každý blok definuje pole svých 4 stavů rotace (`Bloky`) v lokálních souřadnicích.
  * Rotace probíhá změnou indexu stavu, čímž odpadají nepřesnosti při matematických výpočtech na celočíselné mřížce.
  * Metoda `AktualniPozice` počítá aktuální globální pozici kostiček na desce sečtením relativních souřadnic a globálního posunu (`offset`).

---

## Milníky

- [x] **KB1:** Objektový návrh, logika bloků, rotace a mřížka
- [ ] **KB2:** Uživatelské rozhraní (Windows Forms), překreslování a ovládání
- [ ] **KB3:** Herní smyčka, bodování, stupňování obtížnosti a žebříček (I/O)
- [ ] **KB4:** Ošetření výjimek, finální dokumentace a odevzdání
