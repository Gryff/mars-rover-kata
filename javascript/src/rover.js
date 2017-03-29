'use strict'

const rover = {
  move (commands) {
    let x = 0
    let y = 0
    let position = 'N'

    for(let i = 0; i < commands.length; i++) {
      const command = commands[i]

      if (command === 'M') y += 1
      if (command === 'L') position = 'W'
    }

    return `${x}${y}${position}`
  }
}

module.exports = rover
