# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class StartNewKeyPairRequestResponseApiModel(Model):
    """New key pair response.

    :param request_id: Request id
    :type request_id: str
    """

    _validation = {
        'request_id': {'required': True},
    }

    _attribute_map = {
        'request_id': {'key': 'requestId', 'type': 'str'},
    }

    def __init__(self, request_id):
        super(StartNewKeyPairRequestResponseApiModel, self).__init__()
        self.request_id = request_id