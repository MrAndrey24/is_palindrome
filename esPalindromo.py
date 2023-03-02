def remove_spaces(text):
    new_text = ""
    for char in text:
        if char != " ":
            new_text += char
    return new_text


def reverse_text(text):
    reversed_text = ""
    for char in text:
        reversed_text = char + reversed_text
    return reversed_text


def is_palindrome(text):
    text = remove_spaces(text)
    reversed_text = reverse_text(text)
    return text.lower() == reversed_text.lower()


print(is_palindrome("amo la paloma"))
print(is_palindrome("hola mundo"))
print(is_palindrome("ana lava lana"))
print(is_palindrome("racecar"))
print(is_palindrome("A man a plan a canal Panama"))
print(is_palindrome("Was it a car or a cat I saw?"))
print(is_palindrome("Eva, can I see bees in a cave?"))
print(is_palindrome("No 'x' in Nixon"))
