const assert = require('assert');

describe("greet function", () => {
  it("should greet Marcus properly", () => {
    // arrange
    const greeter = require('./index.js');

    // act
    const actualResult = greeter.greet('Marcus');

    // assert
    assert.equal('Welcome to SALT, Marcus', actualResult);
  });
});