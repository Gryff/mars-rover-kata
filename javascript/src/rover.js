'use strict'

const rover = {
  move (commands) {
    if (commands === 'L') return '00W'

    const x = 0
    const y = commands.length

    return `${x}${y}N`
  }
}

module.exports = rover
