CREATE TABLE public.users (
	"user_id" serial NOT NULL UNIQUE,
	"login" TEXT NOT NULL UNIQUE,
	"email" TEXT NOT NULL UNIQUE,
	"passwd" TEXT NOT NULL,
	"phone_number" TEXT NOT NULL UNIQUE,
	CONSTRAINT "users_pk" PRIMARY KEY ("user_id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE public.services (
	"service_id" serial NOT NULL UNIQUE,
	"user_id" integer NOT NULL,
	"service_name" TEXT NOT NULL,
	"login_service" TEXT NOT NULL,
	"passwd_service" TEXT NOT NULL,
	CONSTRAINT "services_pk" PRIMARY KEY ("service_id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE public.credits (
	"credit_id" serial NOT NULL UNIQUE,
	"user_id" integer NOT NULL,
	"credit_number" text NOT NULL,
	"credit_date" text NOT NULL,
	"credit_code" integer NOT NULL,
	CONSTRAINT "credits_pk" PRIMARY KEY ("credit_id")
) WITH (
  OIDS=FALSE
);

ALTER TABLE "services" ADD CONSTRAINT "services_fk0" FOREIGN KEY ("user_id") REFERENCES "users"("user_id");

ALTER TABLE "credits" ADD CONSTRAINT "credits_fk0" FOREIGN KEY ("user_id") REFERENCES "users"("user_id");