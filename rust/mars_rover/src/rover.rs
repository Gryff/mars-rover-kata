pub fn go(commands: &str) -> String {
    "0,0,N".to_string()
}

#[cfg(test)]
mod rover_tests {
    use super::*;

    #[test]
    fn my_first_test() {
        assert_eq!(go(""), "0,0,N");
    }
}
