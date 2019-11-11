package accumulate

func Accumulate(given []string, converter func(string) string) []string {
	converted := []string{}

	for _, v := range given {
		converted = append(converted, converter(v))
	}
	return converted
}
