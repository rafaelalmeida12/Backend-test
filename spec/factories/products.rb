FactoryBot.define do
  factory :todo do
    name {Faker::Lorem.word}
    price {Faker::Number.number(2)}
  end
end