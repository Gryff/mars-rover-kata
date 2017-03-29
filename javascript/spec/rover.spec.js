'use strict'

import test from 'ava'
import rover from '../src/rover'

test('doesnt move when given no commands', t => {
  t.deepEqual(rover.move(''), '00N')
})
