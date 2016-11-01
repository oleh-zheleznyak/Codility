describe("A suite", function () {

    var TapeEquilibrium = require('../Codility.Tasks/Lesson3.TimeComplexity/TapeEquilibrium.js');

    beforeEach(function () {
        tape = new TapeEquilibrium();
    });

    it("contains spec with an expectation", function () {
        var result = tape.solution(null);
        expect(result).toBe(true);
    });
});