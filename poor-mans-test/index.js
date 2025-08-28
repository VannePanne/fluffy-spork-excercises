function greet(namePassedIn) {
    if (!namePassedIn) return "Error: No name provided"
    if (Array.isArray(namePassedIn)){
        return 'Welcome to SALT, ' + namePassedIn.join(' and ');
    }
    return 'Welcome to SALT, ' + namePassedIn;
  }

module.exports.greet = greet;

  const greeting = greet('Marcus');
if(greeting === 'Welcome to SALT, Marcus') {
  console.log('IT WORKS');
}
else {
  console.log('IT FAILS');
}

