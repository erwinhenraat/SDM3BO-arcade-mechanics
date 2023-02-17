# SDM3PROG
**Les 3: Beweging en besturing van gameobjecten**

## Leerdoelen:
* Jullie begrijpen wat een Vector3 is
* Jullie kunnen werken met de Velocity van een gameobject
* Jullie kunnen waarden controleren met Debug.Log()
* Jullie begrijpen waarom snelheden worden vermenigvuldigd met Time.deltaTime
* Jullie kunnen variabelen in de inspector instelbaar maken
* Jullie kunnen met de Unity input controller werken
* Jullie kunnen animaties goed instellen zodat deze goed worden afgespeeld
 
## Planning:
* **10 min.** Uitleg over Vector3 
  * Vector2
  * Vector3
  * Velocity
  * Rotation (transform.Rotate())
* **5 min.** Demo blokje bewegen 
  * naar voren op de Z as
  * op zij op de X as
* **5 min.** Demo blokje bewegen
  * Naar voren via transform.forward
  * Roteren van de y as
* **60 min.** In 2 tallen werken aan de onderstaande opdracht
  * evt. wie wil klassiekaal de opdracht doornemen met de docent
* **15 min.** 3 groepjes laten zien hoe ver ze zijn gekomen en wat ze hebben gedaan
* **10 min.** Klassiekaal terugkijken: Wat ging goed en wat was/is lastig


## Opdracht:
Voer de onderstaande stappen uit en laat voor het einde van de les zien hoe ver je bent gekomen.

Als je klaar bent laat je het ook zien.

Als je vast zit vraag je om hulp!


### 1. Download via Mixamo een character met een "idle" en "walk" of "run" animatie

![Mixamo](../tutorial_gfx/mixamo.png)

* ***Optioneel*** [kun je deze tutorial volgen](https://youtu.be/8Pk7FI629O8)

### 2. Selecteer een character

![Character](../tutorial_gfx/character.png)

### 3. Selecteer een animatie

### 4. Download primaire animatie (idle) met skin

### 5. Selecteer meer animaties en download deze zonder skin

### 6. zorg voor de juiste import settings in Unity

* Model settings:
![Model Settings](../tutorial_gfx/model_settings.png)
* Rig settings:
![Rig Settings](../tutorial_gfx/rig_settings.png)
* Animation settings
![Animation Settings](../tutorial_gfx/animation_settings.png)
* Materials settings
![Materials Settings](../tutorial_gfx/materials_settings.png)
* Click op Extract Textures en Materials en sla deze op in je project
![Extract](../tutorial_gfx/extract.png)

### 7. Sleep je fbx in de scene

![To Scene](../tutorial_gfx/toScene.png)

### 8. Voeg de animator controller toe
  
* Maak een Animator Controller aan 
![Add Animator Controller](../tutorial_gfx/addAnimatorController.png)
* Selecteer je character in de hierarchy
![Char Hierarchie](../tutorial_gfx/charHierarchie.png)
* Selecteer de nieuwe Animator Controller
![Select Animator Controller](../tutorial_gfx/selectAnimatorController.png)
   
### 9. Plaats je animaties in de Animator

* Open het Animator Window
![Open Animator](../tutorial_gfx/openAnimator.png)
* Sleep je animaties in het animator window
![Sleep](../tutorial_gfx/sleep.png)
* Voeg een trigger toe
![Trigger](../tutorial_gfx/trigger.png)
* voeg transitions toe 
![Transition](../tutorial_gfx/transition.png)
* zet als condition de trigger
![Condition](../tutorial_gfx/condition.png)

### 10. Maak code om de animatie aan te roepen
* Hang een nieuw script als component aan je character
* Gebruik de methode [Animator.SetTrigger("value")](https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html)


### 11. Zorg dat er standaard een idle animatie afspeelt en dat je character iets anders doet als je op een knop drukt.
![Animation](../tutorial_gfx/Animation.gif)     

### Commit en push je werk. Laat je Unity scene, je code en je repository zien aan de docent!
