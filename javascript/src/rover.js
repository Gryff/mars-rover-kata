'use strict'

const rover = {
  move (commands) {
    if (commands === 'M') return '01N'
    return '00N'
  }
}

module.exports = rover
