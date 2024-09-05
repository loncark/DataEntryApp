export const nameInputIsValid = (input) => {
    return hasValidCharacters(input) && noSqlInjection(input);
}
function hasValidCharacters(input) {
    const nameRegex = /^[a-zA-Z0-9\s\-']+$/
    return input === '' || (nameRegex.test(input));
}
function noSqlInjection(input) {
    return !/['";%]/.test(input);
}

export const emailInputIsValid = (email) => {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    return email == '' || emailRegex.test(email);
}

export const phoneInputIsValid = (number) => {
    const phoneRegex = /^\+?[1-9]\d{1,14}$/;
    return number == '' || phoneRegex.test(number);
}

export const addressInputIsvalid = (address) => {
    const addressRegex = /^[a-zA-Z0-9\s\-.,']+$/
    return address === '' || (addressRegex.test(address));
}