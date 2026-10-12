# Kobold UI Sample

This repository contains the extracted Simple Sample for Kobold UI.
Use it as a reference for integration, window structure, and common UI flows.

Main repository: https://github.com/KienanUnique/KoboldUiFramework

Animation defaults are configured without DI. `ProjectUiAnimationDefaults` holds
the shared Fade, Scale, and Slide parameters. `MainMenuUiAnimationDefaults`
references it and can override individual parameter types for the local UI.
The UI installers pass these assets explicitly to KoboldUi.
