'use strict'

import test from 'ava'
import rover from '../src/rover'

test('doesnt move when given no commands', t => {
  t.is(rover.move(''), '00N')
})

test('can move forward', t => {
  t.is(rover.move('M'), '01N')
})

test('can move forward twice', testRover, 'MM', '02N')

function testRover (t, commands, expectedPosition) {
  t.is(rover.move(commands), expectedPosition)
}
