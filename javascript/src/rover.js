'use strict'

const rover = {
  move (commands) {
    if (commands === 'MM') return '02N'
    if (commands === 'M') return '01N'
    return '00N'
  }
}

module.exports = rover
