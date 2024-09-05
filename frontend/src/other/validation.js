export const nameInputIsValid = (input) => {
    return notEmpty(input) && hasValidCharacters(input) && noSqlInjection(input);
}
function hasValidCharacters(input) {
    const nameRegex = /^[a-zA-Z0-9\s\-']+$/
    return nameRegex.test(input);
}
function noSqlInjection(input) {
    return !/['";%]/.test(input);
}
function notEmpty(input) {
    return input !== '';
}

export const emailInputIsValid = (email) => {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    return notEmpty(email) && emailRegex.test(email);
}

export const phoneInputIsValid = (number) => {
    const phoneRegex = /^(\+|-)?[1-9]\d{1,14}$/;
    return phoneRegex.test(number);
}

export const addressInputIsvalid = (address) => {
    const addressRegex = /^[a-zA-Z0-9\s\-.,']+$/
    return addressRegex.test(address);
}