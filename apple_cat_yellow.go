package main

import (
	"fmt"
)

func main() {
	// Print a welcome message
	fmt.Println("Welcome to The Next Step!")
	
	// Create a variable to store user input
	var input string
	
	// Get user input
	fmt.Println("What would you like to do next? (Type 'help' for choices)")
	fmt.Scanln(&input)
	
	// Create a switch statement to respond to input
	switch input {
		case "help":
			// Print out available choices
			fmt.Printf("\nAvailable choices are:%s\n%s\n%s\n\n", "set a goal", "learn a skill", "take action")
		case "set a goal":
			// Print out instructions for setting a goal
			fmt.Println("\nThink of a goal that you would like to achieve. Write it down, break it into smaller actionable steps, and review your progress regularly.")
		case "learn a skill":
			// Print out instructions for learning a skill
			fmt.Println("\nChoose a skill you would like to learn. Research different approaches to learning, identify resources, and practice what you learn.")
		case "take action":
			// Print out instructions for taking action
			fmt.Println("\nStart taking action in the direction of your goal. Break it into small steps, and celebrate each step along the way.")
		default:
			// If input does not match any of the available choices, print an error message
			fmt.Println("\nThat's not a valid option.")
	}

	// Create a variable to keep looping
	var repeat bool
	
	// Ask if user wants to repeat
	fmt.Println("\nWould you like to try again? (Type 'yes' or 'no')")
	fmt.Scanln(&input)	
	
	// Take input and set repeat variable
	if input == "yes" {
		repeat = true
	} else {
		repeat = false
	}
	
	// If repeat is true, repeat the loop
	for repeat {
		// Get user input
		fmt.Println("What would you like to do next? (Type 'help' for choices)")
		fmt.Scanln(&input)
	
		// Create a switch statement to respond to input
		switch input {
			case "help":
				// Print out available choices
				fmt.Printf("\nAvailable choices are:%s\n%s\n%s\n\n", "set a goal", "learn a skill", "take action")
			case "set a goal":
				// Print out instructions for setting a goal
				fmt.Println("\nThink of a goal that you would like to achieve. Write it down, break it into smaller actionable steps, and review your progress regularly.")
			case "learn a skill":
				// Print out instructions for learning a skill
				fmt.Println("\nChoose a skill you would like to learn. Research different approaches to learning, identify resources, and practice what you learn.")
			case "take action":
				// Print out instructions for taking action
				fmt.Println("\nStart taking action in the direction of your goal. Break it into small steps, and celebrate each step along the way.")
			default:
				// If input does not match any of the available choices, print an error message
				fmt.Println("\nThat's not a valid option.")
		}
		
		// Ask if user wants to repeat
		fmt.Println("\nWould you like to try again? (Type 'yes' or 'no')")
		fmt.Scanln(&input)	
		
		// Take input and set repeat variable
		if input == "yes" {
			repeat = true
		} else {
			repeat = false
		}
	}
	
	// Print out a goodbye message
	fmt.Println("\nGoodbye!")
}