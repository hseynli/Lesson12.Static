NotStaticClass instance1 = new NotStaticClass(1);
NotStaticClass instance2 = new NotStaticClass(2);

instance1.Method();
instance2.Method();

// static field-ə müraciət birbaşa klas üzərindən gedir
NotStaticClass.field = 1;

instance1.Method();
instance2.Method();