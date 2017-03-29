'use strict'

import test from 'ava'
import rover from '../src/rover'

test('doesnt move when given no commands', testRover, '', '00N')

test('can move forward', testRover, 'M', '01N')
test('can move forward twice', testRover, 'MM', '02N')

test('can turn left', testRover, 'L', '00W')

function testRover (t, commands, expectedPosition) {
  t.is(rover.move(commands), expectedPosition)
}
