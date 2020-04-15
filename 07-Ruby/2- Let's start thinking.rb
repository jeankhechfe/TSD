#1
def min_max(arr)
  min = arr.sort.sum - arr.last
  max = arr.sort.drop(1).sum
  puts "min is #{min}, and max is #{max}"
end 

#2
def decimal(string)
  if string.scan(/[^01]/).empty?
    i = 0;
    sum = 0;
    while i < string.length  do
      if string.split('')[i] == '1'
        sum += 2**i
      end
      i += 1
    end
    return sum
  else
    raise ArgumentError, 'Argument should represents binary' 
  end
end