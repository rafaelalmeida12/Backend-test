module CleanCharacters
  def error_message(array_message)
    error_message = []
    array_message.each {|message| error_message << "#{message} - #{array_message[message][0]}"}
    error_message
  end

  def to_ar(string)
    array = string.gsub(" ", "").tr('[]', '').split(',').map(&:to_s)
    array
  end
end