'use strict'

import test from 'ava'
import rover from '../src/rover'

test('doesnt move when given no commands', t => {
  t.is(rover.move(''), '00N')
})

test('can move forward', t => {
  t.is(rover.move('M'), '01N')
})

test('can move forward twice', t => {
  t.is(rover.move('MM'), '02N')
})