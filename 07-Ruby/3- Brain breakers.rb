class Clock 
  
  include Comparable 

  attr_accessor :hours, :minutes, :seconds

  def initialize(hours, minutes, seconds)
    if hours > 24 || minutes > 60 || seconds > 60 
       raise ArgumentError, 'Argument should represents a time' 
    end
    @hours, @minutes, @seconds = (sprintf '%02d',hours), (sprintf '%02d', minutes), (sprintf '%02d', seconds)
  end

  def print
    "#{@hours}:#{@minutes}:#{@seconds}"
  end

  def +(obj) 
    if @minutes.to_i + obj.to_i < 60
      @minutes = @minutes.to_i + obj.to_i
    else
      hours_added = obj_to_i/60
      @hours = @hours.t0_i + hours_added
      @minutes = @minutes.to_i + obj.to_i - 60
    end
    print
  end

  def <=>(obj) 
      if self.hours<=>obj.hours && self.minutes<=>obj.minutes && self.seconds<=>obj.seconds
        return true
      else
        return false
      end
  end

end