// Copyright Epic Games, Inc. All Rights Reserved.

#include "ue4_cpp_tdsGameMode.h"
#include "ue4_cpp_tdsPlayerController.h"
#include "../Character/ue4_cpp_tdsCharacter.h"
#include "UObject/ConstructorHelpers.h"

Aue4_cpp_tdsGameMode::Aue4_cpp_tdsGameMode()
{
	// use our custom PlayerController class
	PlayerControllerClass = Aue4_cpp_tdsPlayerController::StaticClass();

	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/Blueprint/Character/TopDownCharacter"));
	if (PlayerPawnBPClass.Class != nullptr)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}