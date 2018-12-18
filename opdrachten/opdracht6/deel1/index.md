# Dataformaten

**Jeroen Vervaeck**
**19/12/2018**


### Wat is een dataformaat?
Een dataformaat is de vorm waarin informatie gecodeerd is. De informatie is op zo'n manier gecodeerd dat een programma de data kan herkennen, lezen en gebruiken.

### Welke dataformaten zijn er?
* **byte** - 0 to 255
* **sbyte** - -128 to 127
* **short** - -32 768 to 32 767
* **ushort** - 0 to 65 535
* **int** - -2 147 483 648 to 2 147 483 647
* **uint** - 0 to 4 294 967 295
* **long** - -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807
* **ulong** - 0 to 18 446 744 073 709 551 615
* **float** - -3.402823e38 to 3.402823e38
* **double** - -1.79769313486232e308 to 1.79769313486232e308
* **decimal** - -79228162514264337593543950335 to 79228162514264337593543950335
* **char** - A single Unicode character
* **string** - A string of Unicode characters
* **bool** - True or False
* **object** - An object (the base type for all other types)

### Wat zijn de verschillen?
De reden waarom ze verschillende groottes gebruiken is voor performance. Wanneer je een relatief kleine waarde in een object wil steken, gebruik je een **short**. Niet een long. Dit zorgt ervoor dat de applicatie efficiënter zal lopen, vermindert stress op de server en de gebruiker.