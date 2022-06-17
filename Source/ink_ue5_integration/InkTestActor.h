// Fill out your copyright notice in the Description page of Project Settings.

#pragma once



#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "InkTestActor.generated.h"



UCLASS()
class INK_UE5_INTEGRATION_API AInkTestActor : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AInkTestActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;



};
