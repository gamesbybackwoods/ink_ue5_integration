// Fill out your copyright notice in the Description page of Project Settings.

#include <ink/story.h>
#include <ink/runner.h>
#include <ink/choice.h>

//using namespace ink::runtime;

#include "InkTestActor.h"
#include <iostream>



// Sets default values
AInkTestActor::AInkTestActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AInkTestActor::BeginPlay()
{

	ink::runtime::story* myInk = ink::runtime::story::from_file("test.bin");

	// Create a new thread
	ink::runtime::runner thread = myInk->new_runner();

	// Write to cout
	while (thread->can_continue())
		std::cout << thread->getline();

	
}

