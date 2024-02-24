namespace Hello3.Time {
    public class TimeService : ITimeService {
        public string GetTimeDay(DateTime dateTime) {
            int hours = dateTime.Hour;
            if (hours >= 6 && hours < 12) {
                return $"Зараз ранок ({dateTime})";
            }
            else if (hours >= 12 && hours < 18) {
                return $"Зараз день ({dateTime})";
            }
            else if (hours >= 18 && hours < 24) {
                return $"Зараз вечір ({dateTime})";
            }
            else {
                return $"Зараз ніч, йди спати ({dateTime})";
            }
        }
    }
}