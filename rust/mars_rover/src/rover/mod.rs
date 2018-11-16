mod direction;

pub fn go(commands: &str) -> String {
    let mut y = 0;
    let mut direction = direction::Direction::North;

    for command in commands.chars() {
        if command == 'M' {
            y = (y + 1) % 10;
        }

        if command == 'R' {
            direction = direction.rotate_right();
        }

        if command == 'L' {
            direction = direction.rotate_left();
        }
    }

    format!("0,{},{}", y, direction.to_string())
}

#[cfg(test)]
mod rover_tests {
    use super::*;

    #[test]
    fn starts_at_0_0_n() {
        assert_eq!(go(""), "0,0,N");
    }

    #[test]
    fn can_move_north() {
        assert_eq!(go("M"), "0,1,N");
    }

    #[test]
    fn can_move_north_twice() {
        assert_eq!(go("MM"), "0,2,N");
    }

    #[test]
    fn wraps_around_grid_moving_north() {
        assert_eq!(go("MMMMMMMMMMMM"), "0,2,N");
    }

    #[test]
    fn can_rotate_right() {
        assert_eq!(go("R"), "0,0,E");
        assert_eq!(go("RR"), "0,0,S");
        assert_eq!(go("RRR"), "0,0,W");
        assert_eq!(go("RRRR"), "0,0,N");
    }

    #[test]
    fn can_rotate_left() {
        assert_eq!(go("L"), "0,0,W");
        assert_eq!(go("LL"), "0,0,S");
        assert_eq!(go("LLL"), "0,0,E");
        assert_eq!(go("LLLL"), "0,0,N");
    }
}
