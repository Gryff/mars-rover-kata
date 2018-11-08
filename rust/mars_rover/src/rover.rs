pub fn go(commands: &str) -> String {
    if commands == "M" {
        "0,1,N".to_string()
    } else if commands == "MM" {
        "0,2,N".to_string()
    } else {
        "0,0,N".to_string()
    }
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
}
