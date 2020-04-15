# 1
def fact(n)
 if n == 0
  1
 else
  if n> 0
   (1..n).inject(:*) || 1
  else 
   puts "no factorial for -ve number"
  end
end   
end

#2
class Integer
  def factorial
    (1..self).inject(:*)
  end
end

#3

module InstanceModule
def square
  return self*self
end
end 
class Integer
  include InstanceModule 
end

#4
module ClassModule
def sample (n)
  if n<0
    raise ArgumentError, 'Argument shouldn\'t be negative'
  else
    Array.new(n) { rand(1...9) }
  end
end
end
class Integer
  extend ClassModule 
end