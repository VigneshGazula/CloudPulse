terraform {
  required_version = ">= 1.5.0"

  required_providers {
    aws = {
      source  = "hashicorp/aws"
      version = "~> 5.0"
    }
  }
}

provider "aws" {
  region  = "ap-south-1"
  profile = "cloudpulse-terraform"

  default_tags {
    tags = {
      Project     = "CloudPulse"
      Environment = "demo"
    }
  }
}
