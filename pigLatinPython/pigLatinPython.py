# give instruction and get user input
input = input('Give me a sentence and I will convert it to Pig Latin! ')

# for loop
for words in input.split():
    print(words[1:] + words[0] + "ay")