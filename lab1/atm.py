import time

user = {'username': 'user1', 'PIN': '123456', 'balance': 10000}

def card():
    print("Please wait. Your transaction is being processed....")
    time.sleep(2)  

def login():
    while True:
        entered_PIN = input("Enter your PIN: ")
        time.sleep(1)  
        if entered_PIN == user['PIN']:
            print("Login successful!")
            return True
        else:
            print("Invalid PIN. Please try again.")

def display_balance():
    print(f"Your balance is: {user['balance']}")
    time.sleep(1)

def withdraw():
    entered_PIN = input("Enter your PIN: ")  # Prompt for PIN  when Withdraw
    time.sleep(1)  
    if entered_PIN == user['PIN']:
        while True:
            print("-------------------------------")
            print("Select:")
            print("1. Withdraw an amount")
            print("2. Go back")
            print("-------------------------------")
            option = input("Enter your option (1-2): ")
            print("------------------------------------------------")
            if option == '1': #option 1
                amount = float(input("Enter an amount: "))
                if 0 < amount <= user['balance']:
                    user['balance'] -= amount
                    print("Please wait. Your transaction is being processed.")
                    time.sleep(1.5)
                    print("\nGet your cash.")
                    time.sleep(1.5)
                    print("------------------------------------------------")
                    receipt_choice = input("Do you want a receipt? (Y/N): ")
                    if receipt_choice.lower() == 'y':
                        print("Receipt printed")
                        print("-------------------------------")
                        time.sleep(1.5)
                    another_withdrawal = input("Do you want to perform another withdrawal? (Y/N): ")
                    if another_withdrawal.lower() == 'n':
                        print("\n")
                        return False  # Going back to the main menu
                    elif another_withdrawal.lower() == 'y':
                        continue  # Go back to the beginning of the withdrawal loop
                    else:
                        print("Invalid choice. Returning to the main menu.")
                        return False # Going back to the main menu
                else:
                    print("Insufficient funds or invalid amount.")
                    time.sleep(1)
            elif option == '2':
                return False  # Going back to the main menu
            else:
                print("Invalid option. Please try again.")
    else:
        print("Invalid PIN. Please try again.")
        return False

def deposit():
    while True:
        print("Select:")
        print("1. Deposit an amount")
        print("2. Go back")
        print("-------------------------------")
        option = input("Enter your option (1-2): ")
        if option == '1':
            print("--------------------------------------")
            amount = float(input("Put the amount you want to deposit: "))
            if amount > 0:
                user['balance'] += amount #add the amount
                print("--------------------------------------")
                print(f"Deposit successful. Updated balance: {user['balance']}")
                time.sleep(1.5) 
                print("--------------------------------------")
                another_deposit = input("Do you want to perform another deposit? (Y/N): ")
                if another_deposit.lower() == 'n':
                    print("\n")
                    return False  # Going back to the main menu
                elif another_deposit.lower() == 'y':
                    continue  # Go back to the beginning of the deposit loop
                else:
                    print("Invalid choice. Returning to the main menu.")
                    return False # Going back to the main menu
            else:
                print("Invalid amount. Please try again.")
                time.sleep(1.5)
        elif option == '2':
            return False  # Going back to the main menu
        else:
            print("Invalid option. Please try again.")

def main_menu():
    card()
    print("Welcome to the ZBE.")

    if login():
        while True:
            print("-------------------------------")
            print("Select a transaction:")
            print("-----------------------")
            print("1. Check Balance")
            print("2. Withdraw")
            print("3. Deposit")
            print("4. Exit")
            print("-------------------------------")

            choice = input("Enter your choice (1-4): ")
            print("-------------------------------")
            if choice == '1':
                display_balance()
                another_transaction = input("Do you want to perform another transaction? (Y/N): ")
                if another_transaction.lower() != 'y':
                    print("\nExiting. Thank you and have a nice day!")
                    break
            elif choice == '2':
                while True:
                    if not withdraw():
                        break
                    else:
                        return
            elif choice == '3':
                while True:
                    if not deposit():
                        break
                    else:
                        return
            elif choice == '4':
                print("Exiting. Thank you and have a nice day!!.")
                time.sleep(3)  
                break
            else:
                print("Invalid choice. Please try again.")

# Run the main menu
main_menu()
