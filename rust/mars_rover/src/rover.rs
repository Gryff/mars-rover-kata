pub fn go(commands: &str) -> String {
    let mut x = 0;
    let mut direction = 'N';

    for command in commands.chars() {
        if command == 'M' {
            x = (x + 1) % 10;
        }

        if command == 'R' {
            direction = 'E';
        }
    }

    format!("0,{},{}", x, direction)
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
    }
}
